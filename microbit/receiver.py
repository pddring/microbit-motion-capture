import radio
from microbit import *

# wifi style sending icon
image_send = Image("99900:"
                   "00090:"
                   "99009:"
                   "00909:"
                   "90909")

while True:
    msg = radio.receive()
    if msg == None:
        display.clear()
    else:
        display.show(image_send)
        print(msg)
    sleep(1)

