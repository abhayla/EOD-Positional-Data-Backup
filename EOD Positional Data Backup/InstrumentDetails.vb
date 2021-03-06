﻿<Serializable>
Public Class InstrumentDetails
    <Serializable>
    Enum TypeOfInstrument
        Cash
        Futures
        Currency
        Commodity
        Positional
        OptionChain
    End Enum
    Public Property TradingSymbol As String
    Public Property InstrumentToken As String
    Public Property Segment As String
    Public Property Exchange As String
    Public Property Expiry As Date
    Public Property ErrorMessage As String
    Public Property InstrumentType As TypeOfInstrument
End Class
