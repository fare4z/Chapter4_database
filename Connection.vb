﻿Module Connection
    Public dataAdapter As New OleDb.OleDbDataAdapter
    Public cmd As New OleDb.OleDbCommand
    Public dataSet As New DataSet
    Public con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\MyDB.mdb")
    Public dataReader As OleDb.OleDbDataReader

End Module