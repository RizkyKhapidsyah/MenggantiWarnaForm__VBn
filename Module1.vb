Module Module1
    Public AppPath As String = Replace(
        Replace(Replace(Application.ExecutablePath, Application.ProductName + ".EXE", ""),
        Application.ProductName + ".exe", ""),
        Application.ProductName + ".exe", "")
End Module
