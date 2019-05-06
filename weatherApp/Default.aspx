<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="weatherApp.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgWeatherIcon" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblCity" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgCountryFlag" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblDescription" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblHumidity" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMin" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMax" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblTempDay" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblDate" runat="server"></asp:Label>
				</li>
			</ul>
		</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgWeatherIconDay2" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblCityDay2" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgCountryFlagDay2" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblDescriptionDay2" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblHumidityDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMinDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMaxDay2" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblTempDayDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblDate2" runat="server"></asp:Label>
				</li>
			</ul>
		</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgWeatherIconDay3" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblCityDay3" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgCountryFlagDay3" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblDescriptionDay3" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblHumidityDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMinDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMaxDay3" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblTempDayDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblDate3" runat="server"></asp:Label>
				</li>
			</ul>
		</div>
	</div>
	<div class="row">
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgWeatherIconDay4" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblCityDay4" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgCountryFlagDay4" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblDescriptionDay4" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblHumidityDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMinDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMaxDay4" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblTempDayDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblDate4" runat="server"></asp:Label>
				</li>
			</ul>
		</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgWeatherIconDay5" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblCityDay5" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgCountryFlagDay5" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblDescriptionDay5" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblHumidityDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMinDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblTempMaxDay5" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblTempDayDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblDate5" runat="server"></asp:Label>
				</li>
			</ul>
		</div>
		<div class="col-4">
		</div>
	</div>
	<div class="row">
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgMBayWeatherIconDay" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayCityDay" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgMBayCountryFlagDay" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayDescriptionDay" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayHumidityDay" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMinDay" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMaxDay" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayTempDayDay" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempNightDay" runat="server"></asp:Label>
				</li>
			</ul>
			</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgMBayWeatherIconDay2" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayCityDay2" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgMBayCountryFlagDay2" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayDescriptionDay2" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayHumidityDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMinDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMaxDay2" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayTempDayDay2" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempNightDay2" runat="server"></asp:Label>
				</li>
			</ul>
			</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgMBayWeatherIconDay3" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayCityDay3" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgMBayCountryFlagDay3" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayDescriptionDay3" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayHumidityDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMinDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMaxDay3" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayTempDayDay3" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempNightDay3" runat="server"></asp:Label>
				</li>
			</ul>
			</div>
		</div>
	<div class="row">
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgMBayWeatherIconDay4" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayCityDay4" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgMBayCountryFlagDay4" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayDescriptionDay4" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayHumidityDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMinDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMaxDay4" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayTempDayDay4" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempNightDay4" runat="server"></asp:Label>
				</li>
			</ul>
			</div>
		<div class="col-4">
			<ul>
				<li>
					<asp:Image ID="imgMBayWeatherIconDay5" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayCityDay5" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Image ID="imgMBayCountryFlagDay5" runat="server" />
				</li>
				<li>
					<asp:Label ID="lblMBayDescriptionDay5" runat="server"> </asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayHumidityDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMinDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempMaxDay5" runat="server"></asp:Label>
				</li>
				<li>
					<asp:Label ID="lblMBayTempDayDay5" runat="server"></asp:Label>

				</li>
				<li>
					<asp:Label ID="lblMBayTempNightDay5" runat="server"></asp:Label>
				</li>
			</ul>
			</div>
		</div>
	<div class="row">
		<div class="col-4">
			<ul>
				<li>

					<asp:Button runat="server" ID="btnNotifAll" Text="Notify All Employees" OnClick="btnNotifAll_Click" />
				</li>
			
			</ul>

		</div>
	</div>
</asp:Content>
