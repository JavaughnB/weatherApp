<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="weatherApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<%--Handles city selection--%>
	<br />
	<div class="row">
		<div class="col-sm-4">
			<asp:Label ID="lblCityInput" CssClass="form-control" runat="server">Please enter the name of the city</asp:Label>
		</div>
		<div class="col-sm-3">
			<asp:TextBox ID="txtCity" CssClass="form-control" runat="server"></asp:TextBox>
		</div>
		<div class="col-sm-3">
			<asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCity" ErrorMessage="Can't be left Empty" runat="server"></asp:RequiredFieldValidator>
			<asp:Label ID="lblError" runat="server" Text=""></asp:Label>
		</div>
		<div class="col-sm-3">
			<asp:Button ID="btnEnterCity" runat="server" CssClass="form-control" Text="Submit" OnClick="btnEnterCity_Click" />
		</div>
	</div>
	<div class="row">
			<asp:Repeater ID="rptrWeather" runat="server" OnItemDataBound="rptrWeather_ItemCommand">
				<ItemTemplate>

					<ul>
						<li>
							<asp:Image ID="imgActive" ImageUrl="~/IMAGE_NAME" runat="server" /></li>
						<li>
							<asp:Label ID="lblDescription" runat="server"></asp:Label></li>
						<li>
							<asp:Label ID="lblTemp" runat="server"></asp:Label></li>
						<li>
							<asp:Label ID="lblHumidity" runat="server"></asp:Label></li>
						<li>
							<asp:Label ID="lblDate" runat="server"></asp:Label>
						</li>
						<li>
							<asp:Label ID ="lblDay" runat="server"></asp:Label>
						</li>
					</ul>
				</ItemTemplate>
			</asp:Repeater>
	</div>
	<br/>
	<div class="row">
		<div class="col-sm-4">
				<asp:Button ID="btnEmailSubmit" CssClass="form-control" runat="server" Text="Notify" OnClick="btnEmailSubmit_Click" />
			</div>
	</div>
</asp:Content>
