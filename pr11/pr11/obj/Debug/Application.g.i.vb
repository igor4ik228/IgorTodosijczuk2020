﻿#ExternalChecksum("..\..\Application.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","25DB22DBBC50B238BAD5490725C85DBB69517F0EFC8FF7946E369B5A25E14992")
'------------------------------------------------------------------------------
' <auto-generated>
'     Этот код создан программой.
'     Исполняемая версия:4.0.30319.42000
'
'     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
'     повторной генерации кода.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports pr11
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Application
'''</summary>
Partial Public Class Application
    Inherits System.Windows.Application
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent()
        
        #ExternalSource("..\..\Application.xaml",5)
        Me.StartupUri = New System.Uri("MainWindow.xaml", System.UriKind.Relative)
        
        #End ExternalSource
    End Sub
    
    '''<summary>
    '''Application Entry Point.
    '''</summary>
    <System.STAThreadAttribute(),  _
     System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Shared Sub Main()
        Dim app As Application = New Application()
        app.InitializeComponent
        app.Run
    End Sub
End Class

