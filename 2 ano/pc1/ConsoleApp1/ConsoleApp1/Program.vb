Imports System.Console

Module Module1
	Sub Main()
		Dim lado As Single, area As Single
		Write("Digite lado: ")
		lado = Single.Parse(ReadLine())
		area = lado * lado
		Write("a area é:")
		Write(area)
	End Sub
End Module
