# video-streamer

This is a Windows application to stream videos frame-by-frame (in base64) to a web server.

![Main form](./readme_images/MainForm.png)

## How to use

1. Select the video source: Video file or camera;
2. Setup the destination
3. Click ```Start Streaming```

## How it works

Every frame of your video will be converted to a string in base64 and then concatenated to the **Body content** where the keyword ```$frame$``` is located.

The response string is printed in the bottom textbox.

### References

[1] Original project: [WebcamApp](https://github.com/katarzynaB99/WebcamApp) from *katarzynaB99*