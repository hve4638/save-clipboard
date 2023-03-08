# save-clipboard

![img2](https://user-images.githubusercontent.com/47706364/223698044-3c0c8f2b-2062-4151-9b14-04c7c9340b5b.gif)

Easily save an image or text from the clipboard using the window context.

## install

[Download](https://drive.google.com/file/d/1nucZf4rVhHNsUTaaciWbKqeJDSsi1Exv/view?usp=sharing)

The installer file exceeds the maximum size allowed on github, so I'm linked it instead.

For a manual installation, follow the steps below.

## Manual installation

1. Download and unzip the `for-menual-install.zip` file from [Releases](https://github.com/hve4638/save-clipboard/releases).
 
2. Move `saveclipboard.exe` into the desired folder.

- The default folder for the installer is `C:\Program Files (x86)\Hve\SaveClipbaord\`

3. Paste the text below into Notepad.

```
Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\Directory\Background\shell\SaveClipboard]
@="Save Clipboard"
"Icon"="[TARGETDIR]saveclipboard.exe"

[HKEY_CLASSES_ROOT\Directory\Background\shell\SaveClipboard\command]
@="\"[TARGETDIR]saveclipboard.exe\" \"%V\""
```

4. Convert `[TARGETDIR]` to the path to the folder where the program is located.
The path must have a '\\' at the end.

5. Save the file with a *.reg extension and run it.
