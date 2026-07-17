import radio
from microbit import *

# device ID can be any number or letter
id_int = 0
id_str = "0"
ids = "01234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ"

# wifi style sending icon
image_send = Image("99900:"
                   "00090:"
                   "99009:"
                   "00909:"
                   "90909")

# modes:
MODE_OFF = 0
MODE_TEMPORARILY_ON = 1
MODE_TOGGLED_ON = 2
mode = MODE_OFF
while True:
    # Press and hold button a to transmit accelerometer data
    if button_a.is_pressed():
        mode = MODE_TEMPORARILY_ON
        if button_b.is_pressed():
            mode = MODE_TOGGLED_ON
            display.show(Image.YES)
            sleep(500)
            
            # keep holding both buttons to turn sending back off
            if button_b.was_pressed() and button_a.is_pressed():
                display.show(Image.NO)
                sleep(500)
                mode = MODE_OFF
    else:
        if mode == MODE_TEMPORARILY_ON:
            mode = MODE_OFF
        
        # press button b to toggle device ID
        if button_b.was_pressed():
            id_int = (id_int + 1) % len(ids)
            id_str = ids[id_int]
        display.show(id_str)
        
    # transmit accelerometer values unless in OFF mode
    if mode > 0:
        display.show(image_send)
        x = accelerometer.get_x()
        y = accelerometer.get_y()
        z = accelerometer.get_z()
        msg = "{} {} {} {}".format(id_str, x,y,z)
        
        # send via radio
        radio.send(msg)
        
        # output to REPL (for debugging)
        print(msg)
    sleep(10)
