#Project - Google Photos Video Edit

##Purpose

1. Add resume experience, and stand out in video related teams.
2. Guide what to learn, and put them together to solve one realistic problem.

##Target
#####Stage1
Clarify all related skills needed to finish the project by finishing the project document.

#####Stage2
Finish key function APIs and test cases.

#####Stage3
Finish functions

##KeyPoint
#### 1. videos upload and store
1. [ ] Where the videos from
	- [ ] Computer : _Mac_ | Windows | Linux
	- [ ] iPhone
	- [ ] Android
	- [ ] Camera : SD card
2. [ ] Where the videos go
	- [ ] _Cloud : AWS | Azure | Google Cloud_
	- [ ] Original place : store where they are from
3. [ ] Upload APIs
3. [ ] Store stratagem 



#### 2. videos clip and joint using ffmpeg 
> command line :

~~~ go
//read info and write into file in json:
$ ffprobe -v quiet -print_format json -show_format input.mp4 >info.txt
$ ffprobe -v quiet -print_format json -show_streams input.mp4 >>info.txt

//play video
$ ffplay input.mp4  
$ ffplay -vf "drawtext=text='%{pts\:hms}':box=1:x=(w-tw)/2:y=h-(2*lh)" input.mp4 

//clip :
$ ffmpeg -i input.mp4 -c copy -ss 00:00:15 -t 00:00:10 output2.mp4

//merge:
$ echo file out_Part_1.mp4 > mylist.txt
$ echo file out_Part_2.mp4 >> mylist.txt
$ ffmpeg -f concat -i mylist.txt -c copy out_merged.mp4

//merge segments without clip first
$ ffmpeg -i input.mp4 -filter_complex "[0:v]trim=duration=10[av];[0:a]atrim=duration=10[aa];[0:v]trim=start=30:end=40,setpts=PTS-STARTPTS[bv];[0:a]atrim=start=30:end=40,asetpts=PTS-STARTPTS[ba];[av][bv]concat[outv];[aa][ba]concat=v=0:a=1[outa]" -map [outv] -map [outa] outtest2.mp4

// using duration and start/end
$ ffmpeg -i input.mp4 -filter_complex "[0:v]trim=duration=5[av];[0:a]atrim=duration=5[aa];[0:v]trim=start=60:end=65,setpts=PTS-STARTPTS[bv];[0:a]atrim=start=100:end=105,asetpts=PTS-STARTPTS[ba];[av][bv]concat[outv];[aa][ba]concat=v=0:a=1[outa]" -map [outv] -map [outa] outtest5.mp4

// using timebase ;before use ffprobe -shwo_streams to checkout the timebase of video and audio
$ ffmpeg -i input.mp4 -filter_complex "[0:v]trim=start_pts=120000:end_pts=210000,setpts=PTS-STARTPTS[av];
[0:a]atrim=start_pts=192000:end_pts=336000,asetpts=PTS-STARTPTS[aa];[0:v]trim=start_pts=350000:end_pts=1000000,setpts=PTS-STARTPTS[bv];[0:a]atrim=start_pts=576000:end_pts=1600000,asetpts=PTS-STARTPTS[ba];[av][bv]concat[outv];[aa][ba]concat=v=0:a=1[outa]" -map "[outv]" -map "[outa]" outtest13.mp4

~~~

#### 3. videos compress
1. [ ] _Tech_ Compress methods
2. [ ] _Tech_ Compress target


#### 4. videos play on the cloud/local
1. [ ] Preview the video when select 
	- [ ] Show the thumbnail of the video
	- [ ] Show the total time duration
	- [ ] Preview (not necessary, can preview at next step)
2. [ ] Show the video before clip 
	- [ ] Preview video while editing
	- [ ] Show the timestamp of the video (enable to keep the timestamp down)
	- [ ] show the clip range 	
3. [ ]Show the video before merge
	- [ ] show the merged pieces
	- [ ] show the total time duration


ffmpeg -i input.mp4 -i out_merged.mp4 -i input.mp4 -filter_complex "[0:v]trim=0:5,setpts=PTS-STARTPTS[0v];[0:a]atrim=0:5,asetpts=PTS-STARTPTS[0a];[1:v]trim=9:15,setpts=PTS-STARTPTS[1v];[1:a]atrim=9:15,asetpts=PTS-STARTPTS[1a];[2:v]trim=30:40,setpts=PTS-STARTPTS[2v];[2:a]atrim=30:40,asetpts=PTS-STARTPTS[2a];[0v][0a][1v][1a][2v][2a]concat=n=3:v=1:a=1[outv][outa]" -map "[outv]" -map "[outa]" outtest0.mp4


ffmpeg -i input.mp4 -filter_complex "[0:v]trim=duration=5[av];[0:a]atrim=duration=5[aa];[0:v]trim=start=60:end=65,setpts=PTS-STARTPTS[bv];[0:a]atrim=start=100:end=105,asetpts=PTS-STARTPTS[ba];[av][bv]concat[outv];[aa][ba]concat=v=0:a=1[outa]" -map [outv] -map [outa] outtest5.mp4

ffmpeg -i input.mp4 -filter_complex "[0:v]trim=start_pts=120000:end_pts=210000,setpts=PTS-STARTPTS[av];
[0:a]atrim=start_pts=192000:end_pts=336000,asetpts=PTS-STARTPTS[aa];[0:v]trim=start_pts=350000:end_pts=1000000,setpts=PTS-STARTPTS[bv];[0:a]atrim=start_pts=576000:end_pts=1600000,asetpts=PTS-STARTPTS[ba];[av][bv]concat[outv];[aa][ba]concat=v=0:a=1[outa]" -map "[outv]" -map "[outa]" outtest13.mp4





#### 5. [Advance] user interface
#### 6. [**Advance] 

---

- 05.15 --- v1.0 demo 

> define demo functions
> define Video class
>> ref :
>>	[HOW TO RETRIEVE THE VIDEO PROPERTIES(java)](http://www.javacreed.com/how-to-retrieve-the-video-properties/)
>> [Inspect a video file with Xuggler(Xuggler)](https://examples.javacodegeeks.com/desktop-java/xuggler/inspect-a-video-file-with-xuggler/)
>>[ffprobe,ffplay ffmpeg常用的命令行命令](https://juejin.im/post/5a59993cf265da3e4f0a1e4b)
>>[ffmpeg常用参数一览表](https://blog.csdn.net/maopig/article/details/6610257#)
>> [How to Save the Output of a Command to a File in Bash (aka the Linux and macOS Terminal)](https://www.howtogeek.com/299219/how-to-save-the-output-of-a-command-to-a-file-in-bash-aka-the-linux-and-macos-terminal/)
>> [101 Bash Commands and Tips for Beginners to Experts](https://dev.to/awwsmm/101-bash-commands-and-tips-for-beginners-to-experts-30je)
>> [Java - Period and Duration](https://docs.oracle.com/javase/tutorial/datetime/iso/period.html)
>> [Java 8 – Period and Duration examples](https://www.mkyong.com/java8/java-8-period-and-duration-examples/)
>> [How to parse JSON in Java
](https://stackoverflow.com/questions/2591098/how-to-parse-json-in-java)
>> [Mac 配置FFmpeg环境](https://blog.csdn.net/StoneNotes/article/details/68958332)
>> [Mac OS X Terminal 101：终端使用初级教程](https://www.renfei.org/blog/mac-os-x-terminal-101.html)
>> [Java获取当前路径](https://www.cnblogs.com/diyunpeng/archive/2011/06/06/2073567.html)

> Useful link
> > [FFmpeg Bug Tracker and Wiki](https://trac.ffmpeg.org/wiki)
> > > [Concatenating media files](https://trac.ffmpeg.org/wiki/Concatenate)
> 
> sublime : set defualt open application
> > $ alias subl="'/Applications/Sublime Text.app/Contents/SharedSupport/bin/subl'"
