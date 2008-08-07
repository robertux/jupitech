Namespace Entidades
    Public Class Abono
        Private _codigo As Integer
        Private _fechaLimPago As DateTime
        Private _fechaPago As DateTime
        Private _monto As Double
        Private _interesNormal As Double
        Private _interesMora As Double
        Private _venta As Integer
        
        Public Property Venta() As Integer
            Get
                Return Me._venta
            End Get
            Set(ByVal value As Integer)
                Me._venta = Value
            End Set
        End Property
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property FechaLimPago() As DateTime
            Get
                Return _fechaLimPago
            End Get
            Set(ByVal value As DateTime)
                _fechaLimPago = value
            End Set
        End Property
        Public Property FechaPago() As DateTime
            Get
                Return _fechaPago
            End Get
            Set(ByVal value As DateTime)
                _fechaPago = value
            End Set
        End Property
        Public Property Monto() As Double
            Get
                Return _monto
            End Get
            Set(ByVal value As Double)
                _monto = value
            End Set
        End Property
        Public Property InteresNormal() As Double
            Get
                Return _interesNormal
            End Get
            Set(ByVal value As Double)
                _interesNormal = value
            End Set
        End Property
        Public Property InteresMora() As Double
            Get
                Return _interesMora
            End Get
            Set(ByVal value As Double)
                _interesMora = value
            End Set
        End Property

        Public Sub New(ByVal codigo As Integer, ByVal fechaLimPago As DateTime, ByVal fechaPago As DateTime, ByVal monto As Double, ByVal interesNormal As Double, ByVal interesMora As Double, ByVal venta As Integer)
            Me.Codigo = codigo
            Me.FechaLimPago = fechaLimPago
            Me.FechaPago = fechaPago
            Me.Monto = monto
            Me.InteresNormal = interesNormal
            Me.InteresMora = interesMora
            Me.Venta = venta
        End Sub

    End Class
End Namespace
