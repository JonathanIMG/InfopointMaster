Public Class wErikaPrueba
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




    End Sub
#Region "PROPIEDADES"
    Public WriteOnly Property pBoolIniCtr As Boolean
        Set(value As Boolean)
            If value Then

            End If
        End Set
    End Property
    Dim _IdPagina As Integer
    Public Property pIdPagina As Integer
        Get
            Return _IdPagina
        End Get
        Set(value As Integer)
            _IdPagina = value
        End Set
    End Property

#End Region
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = "Hola Mundo"
        Me.Label2.Text = "JOnathan"
        Me.Label3.Text = "JOnathan 1"

        Me.Label3.Text = "JOnathan 1"
        Me.Label3.Text = "JOnathan 1"
        Me.Label3.Text = "JOnathan 1"
        Me.Label3.Text = "JOnathan 1"
    End Sub
End Class