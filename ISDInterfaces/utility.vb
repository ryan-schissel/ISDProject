Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
' Util-1 More namespaces.
Imports System.Configuration

Namespace SimpleDataApp
    Friend Class Utility

        ' Get connection string from App config file.
        Friend Shared Function GetConnectionString() As String

            ' Util-2 Assume failure.
            Dim returnValue As String = Nothing

            ' Util-3 Look for the name in the connectionStrings section.
            Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ISDInterfaces.My.MySettings.connString")

            ' If found, return the connection string.
            If settings IsNot Nothing Then
                returnValue = settings.ConnectionString
            End If

            Return returnValue
        End Function
    End Class
End Namespace
