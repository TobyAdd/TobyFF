@echo off


cls
title TobyFF [Rendering]
ffmpeg -i "C:\Users\TobyAdd\Videos\wave_cursed.mp4" -vf "setpts=0.25*PTS" -filter:a "atempo=4",scale=640:360  "C:\Users\TobyAdd\Desktop\123123324234.mp4"
title TobyFF [Done]
Pause
