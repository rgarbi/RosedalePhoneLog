﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="PhoneLog.WebForm3" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">Start Date</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Month</asp:TableCell>
            <asp:TableCell>Day</asp:TableCell>
            <asp:TableCell>Year</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
        <select name="month">
            <option selected="selected" value=""></option>
             <option value="1">1</option>
             <option value="2">2</option>
             <option value="3">3</option>
             <option value="4">4</option>
             <option value="5">5</option>
             <option value="6">6</option>
             <option value="7">7</option>
             <option value="8">8</option>
             <option value="9">9</option>
             <option value="10">10</option>
             <option value="11">11</option>
             <option value="12">12</option>
            </select> 
            </asp:TableCell>
            <asp:TableCell>
                <select name="day">
                     <option selected="selected" value=""></option>
                     <option value="1">1</option>
                     <option value="2">2</option>
                     <option value="3">3</option>
                     <option value="4">4</option>
                     <option value="5">5</option>
                     <option value="6">6</option>
                     <option value="7">7</option>
                     <option value="8">8</option>
                     <option value="9">9</option>
                     <option value="10">10</option>
                     <option value="11">11</option>
                     <option value="12">12</option>
                     <option value="13">13</option>
                     <option value="14">14</option>
                     <option value="15">15</option>
                     <option value="16">16</option>
                     <option value="17">17</option>
                     <option value="18">18</option>
                     <option value="19">19</option>
                     <option value="20">20</option>
                     <option value="21">21</option>
                     <option value="22">22</option>
                     <option value="23">23</option>
                     <option value="24">24</option>
                     <option value="25">25</option>
                     <option value="26">26</option>
                     <option value="27">27</option>
                     <option value="28">28</option>
                     <option value="29">29</option>
                     <option value="30">30</option>
                     <option value="31">31</option>
                     </select>
            </asp:TableCell>
            <asp:TableCell>
                <select name="year">
                     <option selected="selected"value="2013">2013</option>
                     <option value="2014">2014</option>
                     <option value="2015">2015</option>
                     <option value="2016">2016</option>
                     <option value="2017">2017</option>
                    </select>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3"></asp:TableCell></asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3"></asp:TableCell></asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3">End Date</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Month</asp:TableCell>
            <asp:TableCell>Day</asp:TableCell>
            <asp:TableCell>Year</asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
        <select name="month2">
             <option selected="selected" value=""></option>
             <option value="1">1</option>
             <option value="2">2</option>
             <option value="3">3</option>
             <option value="4">4</option>
             <option value="5">5</option>
             <option value="6">6</option>
             <option value="7">7</option>
             <option value="8">8</option>
             <option value="9">9</option>
             <option value="10">10</option>
             <option value="11">11</option>
             <option value="12">12</option>
            </select> 
            </asp:TableCell>
            <asp:TableCell>
                <select name="day2">
                     <option selected="selected" value=""></option>
                     <option value="1">1</option>
                     <option value="2">2</option>
                     <option value="3">3</option>
                     <option value="4">4</option>
                     <option value="5">5</option>
                     <option value="6">6</option>
                     <option value="7">7</option>
                     <option value="8">8</option>
                     <option value="9">9</option>
                     <option value="10">10</option>
                     <option value="11">11</option>
                     <option value="12">12</option>
                     <option value="13">13</option>
                     <option value="14">14</option>
                     <option value="15">15</option>
                     <option value="16">16</option>
                     <option value="17">17</option>
                     <option value="18">18</option>
                     <option value="19">19</option>
                     <option value="20">20</option>
                     <option value="21">21</option>
                     <option value="22">22</option>
                     <option value="23">23</option>
                     <option value="24">24</option>
                     <option value="25">25</option>
                     <option value="26">26</option>
                     <option value="27">27</option>
                     <option value="28">28</option>
                     <option value="29">29</option>
                     <option value="30">30</option>
                     <option value="31">31</option>
                    </select>
            </asp:TableCell>
            <asp:TableCell>
                <select name="year2">
                     <option selected="selected"value="2013">2013</option>
                     <option value="2014">2014</option>
                     <option value="2015">2015</option>
                     <option value="2016">2016</option>
                     <option value="2017">2017</option>
                    </select>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="3"><input type="submit" value="submit" name="submit" /></asp:TableCell></asp:TableRow>
    </asp:Table>
</asp:Content>
