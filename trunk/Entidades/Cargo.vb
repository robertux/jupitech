Namespace Entidades
    Public Class Cargo

        Private _fechaLimitePago As Date
        Private _fechaPago As Date
        Private _monto As Double
        Private _prcntInteresNormal As Double
        Private _prcntInteresMora As Double
        Private _compra As Integer
        Private _codigo As Integer
        
        Public Property FechaLimitePago() As Date
            Get
                Return _fechaLimitePago
            End Get
            Set(ByVal value As Date)
                _fechaLimitePago = value
            End Set
        End Property
        Public Property FechaPago() As Date
            Get
                Return _fechaPago
            End Get
            Set(ByVal value As Date)
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
        Public Property PrcntInteresNormal() As Double
            Get
                Return _prcntInteresNormal
            End Get
            Set(ByVal value As Double)
                _prcntInteresNormal = value
            End Set
        End Property
        Public Property PrcntInteresMora() As Double
            Get
                Return _prcntInteresMora
            End Get
            Set(ByVal value As Double)
                _prcntInteresMora = value
            End Set
        End Property
        Public Property Compra() As Integer
            Get
                Return _compra
            End Get
            Set(ByVal value As Integer)
                _compra = value
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
        
        Public Sub New(ByVal fechaLimitePago As Date, ByVal fechaPago As Date, ByVal monto As Double, ByVal prcntInteresNormal As Double, ByVal prcntInteresMora As Double, ByVal codigo As String, ByVal compra As Integer)
            Me.Codigo = codigo
            Me.Compra = compra
            Me.FechaLimitePago = fechaLimitePago
            Me.FechaPago = fechaPago
            Me.Monto = monto
            Me.PrcntInteresMora = prcntInteresMora
            Me.PrcntInteresNormal = prcntInteresNormal
        End Sub

    End Class
End Namespace
