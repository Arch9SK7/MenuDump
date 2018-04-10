#All credit for SleepLZEditor goes to TheCyberQuake

Features:
Read color data from sleep_LZ.bin.bin (sleep_LZ.bin LZ11 decompressed with MSBT Editor Reloaded)
Write color data to sleep_LZ.bin.bin
Save current colors to .slzt color theme file
Open .slzt color theme file
Note:
This is currently a beta. I've tested it pretty well, but there are probably some ways to break it. If you find any bugs, please report them on github!


Releases:
Releases will be found on the github linked below:
https://github.com/TheCyberQuake/SleepLZColorEditor/releases

Requirements:
WIndows with latest .net framework

Planned features:
I'm looking into the possibility of creating a python script to install .slzt color themes directly into a decompressed sleep_LZ.bin. That would at least open up the possibility to install custom color themes on other platforms, even if you can't currently create color themes on those platforms.

Updates:
1.1.1:
- Fix bug where leading 0 of a low value hex byte was dropped, ie 04 was being read as 4, 00 was being read as 0
- Prevent user from inputing an invalid sleep_LZ.bin.bin. Throws a plain-english error rather than a crash.

1.1.2:
- Change input file to match decompression output from MenuDump pack
- Show message box to show that your file was written to

Color Theme Files (.slzt):
Color theme files allow you to save and share your color edits with the community!
With the color edits you wish to share loaded into the color editor, simply use teh "Save Theme File" option
If you wish to use a color theme, simply use the open theme file option!
This pack comes with a green and purple color theme to demonstrate the functionality.