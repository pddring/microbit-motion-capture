using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotionCaptureServer
{
    internal class MotionCapture
    {
        /// <summary>
        /// Defines the possible connection states for the micro:bit device.
        /// </summary>
        public enum ConnectionState {
            Connected,
            Disconnected
        }

        private int packetsReceived = 0;

        public int PacketsReceived
        {
            get { return packetsReceived; }
        }

        /// <summary>
        /// Keeps track of the connection state of the micro:bit device.
        /// </summary>
        private ConnectionState connected = ConnectionState.Connected;

        /// <summary>
        /// Gets the current connection state of the micro:bit device.
        /// </summary>
        public ConnectionState Connected {
            get { return connected; }
        }

        /// <summary>
        /// Detects available serial ports on the system and returns them as an array of strings.
        /// </summary>
        /// <returns></returns>
        public string[] DetectMicrobitPorts() {
            return SerialPort.GetPortNames();
        }

        private SerialPort? port = null;

        /// <summary>
        /// Disconnects from the currently connected serial port, if any, and updates the connection state to Disconnected.
        /// </summary>
        public void Disconnect() {
            if(port!= null) {
                port.Close();
                port = null;
            }
            connected = ConnectionState.Disconnected;
            packetsReceived = 0;
        }


        /// <summary>
        /// Connects to the specified serial port and sets up a data received event handler that invokes the provided callback function when data is received.
        /// </summary>
        /// <param name="PortName"></param>
        /// <param name="OnReceiveData"></param>
        public void Connect(string PortName, Action<string> OnReceiveData) {
            Disconnect();
            connected = ConnectionState.Connected;
            SerialPort port = new SerialPort(PortName, 115200, Parity.None, 8, StopBits.One);
            port.DataReceived += (object sender, SerialDataReceivedEventArgs e) =>
            {
                string data = port.ReadLine();
                packetsReceived++;
                if (OnReceiveData != null)
                {
                    OnReceiveData(data);
                }
            };

            try
            {
                port.Open();
            }
            catch (Exception ex)
            {
                connected = ConnectionState.Disconnected;
                throw ex;
            }
        }

    }
}
