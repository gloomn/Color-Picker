# Color Picker
![GitHub](https://img.shields.io/badge/developer-gloomn-blue)
![GitHub](https://img.shields.io/github/license/gloomn/Color-Picker)
![GitHub](https://img.shields.io/github/languages/top/gloomn/Color-Picker)
![GitHub](https://img.shields.io/github/languages/code-size/gloomn/Color-Picker)
---
 Color Picker Program written with C# Windows Form
 
 ---
 ### Features
 * This project used ```Bitmap``` and ```Graphics.CopyFromScreen``` to capture the screen live
 * V1.2.4 is updated version but it is not completed. You can't use it yet
 
 ### If the file doesn't open
If visual studio has a error like
* ```인터넷 또는 제한 영역에 있거나 파일에 웹 마크가있어 파일 resx를 처리 할 수 없습니다.```
* ```Couldn't process file resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files.```

개별적으로 또는 .zip 파일 또는 이와 유사한 내부에서 인터넷에서 파일을 다운로드 한 경우 인터넷 영역에서 오는 것으로 플래그가 지정되어 “잠김”되었을 수 있습니다. 많은 프로그램에서이를 콘텐츠를 신뢰할 수 없다는 신호로 사용합니다.

가장 간단한 해결 방법은 Windows 탐색기에서 파일을 마우스 오른쪽 단추로 클릭하고 속성을 선택한 다음이 대화 상자 하단에 “차단 해제”옵션이 있어야합니다. 변경 사항을 적용하려면 확인을 클릭해야합니다.

If you have downloaded files from the internet either individually or inside a .zip file or similar, they may have been flagged as coming from the internet zone and “locked down”. Many programs use this as a signal that the content cannot be trusted.

The simplest workaround is to right click on the file in windows explorer, select properties and there should be an "unblock" option at the bottom of this dialog. You must click OK to apply the changes.

<img src="https://user-images.githubusercontent.com/86612194/167292555-df35b2ad-a5c4-4116-aae5-ea0f3a0d1cc5.png" width = "80%" hegiht = "80%">
<img src = "https://user-images.githubusercontent.com/86612194/167292640-adc5351f-070d-4b14-a6ff-32a3e035bc69.png">
* After this progress, you can use file normally
 
 ### Added
 * HEX
 * RGB
 * Darkmode

### Screen Shot
![image](https://user-images.githubusercontent.com/86612194/166908233-0f3134f0-8856-424d-9b9a-fca2301859a4.png)


### Development Information
* .NET Framework 4.7.2
* C# 7.3
* Visual Studio 2022

### Contact
* ```ithan0704@naver.com``` or ```hexahedron74@naver.com```
* https://syntaxack-team.netlify.app/

### Change History
#### V1.0.0
New: Pick color on your screen with Hex and RGB
