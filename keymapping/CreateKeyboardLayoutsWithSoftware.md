# Create keyboard layouts with software

Previuosly you needed custom firmware like ZMK to create custom keyboard layout - Now all you need is a keymapper tool.



# Need to know before the adventure can begin

On windows (and Linux??) signals from the keyboard are interpreted before keys are shown on the screen. Specifically the non-US keyboards operate by sending US key codes that are then interpreted by the operating system. The danish `Æ` when pressed sends a `Semicolon` signal. When remapping, it is the US keycodes that are important, not whatever is drawn on your keyboard key caps!

A very nice tool to help reavel the keycodes to remap is https://www.toptal.com/developers/keycode



Here is a list of free keymapping software and their evaluation

## KMonad 
free, Windows/Linux/Mac
Probablly the most popular open source keymapping software. Modding `ALT` keys on Windows caused issues with e.g. `ALt+Tab` and `ALT` for column selection. So my experiences are limited.


## keymapper 
https://github.com/houmain/keymapper free, Windows/Linux/Mac

A simple and lightweight keymapper with a clean configuration. Allows remapping of all keys including multimedia and function keys. Configurations are found here [houmain/keymapper](configurations/houmain-keymapper/)


I've made a simple layout->config compiler that given a keyboard layout can spit out keymapper `.conf` files. [here](../tools/GenericConfigurationBuilder/GenericConfigurationBuilder/Program.cs)   