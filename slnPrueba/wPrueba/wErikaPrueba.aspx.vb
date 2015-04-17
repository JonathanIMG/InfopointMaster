Public Class wErikaPrueba
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Label1.Text = "Hola Mundo"
        Me.Label2.Text = "JOnathan"
        Me.Label3.Text = "JOnathan 1"


    End Sub


End Class