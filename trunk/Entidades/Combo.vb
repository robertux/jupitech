Namespace Entidades
    Public Class Combo
        Private _nombre As String
        Private _descripcion As String
        Private _codigo As Integer
        Private _promocion as Promocion
        
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
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
        Public Property Descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property
  	Public Property Promocion As Promocion
  		Get
  			return me._promocion
  		End Get
  		Set
  			me._promocion = value
  		End Set
  	End Property
  
        Public Sub New(ByVal nombre As String, ByVal descripcion As String, ByVal codigo As Integer, byval promocion as Promocion)
            Me.Nombre = nombre
            Me.Descripcion = descripcion
            Me.Codigo = codigo
            me.Promocion = promocion
        End Sub

    End Class
End Namespace
