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

while True:
    # Press and hold button a to transmit accelerometer data
    if button_a.is_pressed():
        display.show(image_send)
        x = accelerometer.get_x()
        y = accelerometer.get_y()
        z = accelerometer.get_z()
        msg = "{} {} {} {}".format(id_str, x,y,z)
        radio.send(msg)
        print(msg)
    
    else:
        # press button b to toggle device ID
        if button_b.was_pressed():
            id_int = (id_int + 1) % len(ids)
            id_str = ids[id_int]
        display.show(id_str)
    sleep(10)

