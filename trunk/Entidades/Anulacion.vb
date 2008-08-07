Namespace Entidades
    Public Class Anulacion
        Private _fechaAnulacion As Date
        Private _tipoCompensacion As String
        Private _codigo As Integer
        Private _motivo As String
        Private _venta as Venta
        
        Public Property Venta As Venta
        	Get
        		return me._venta
        	End Get
        	Set
        		me._venta = value
        	End Set
        End Property
        Public Property FechaAnulacion() As Date
            Get
                Return _fechaAnulacion
            End Get
            Set(ByVal value As Date)
                _fechaAnulacion = value
            End Set
        End Property
        Public Property TipoCompansacion() As String
            Get
                Return _tipoCompensacion
            End Get
            Set(ByVal value As String)
                _tipoCompensacion = value
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
        Public Property Motivo() As String
            Get
                Return _motivo
            End Get
            Set(ByVal value As String)
                _motivo = value
            End Set
        End Property
        
        Public Sub New(ByVal fechaAnulacion As Date, ByVal tipoCompensacion As String, ByVal codigo As Integer, ByVal motivo As String, byval venta as Venta)
            Me.FechaAnulacion = fechaAnulacion
            Me.TipoCompansacion = tipoCompensacion
            Me.Codigo = codigo
            Me.Motivo = motivo
            me.Venta = venta
        End Sub

    End Class
End Namespace
