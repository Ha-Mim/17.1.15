﻿<%@ Page Language="cs" AutoEventWireup="false" CodeBehind="Ha-Mim.aspx.cs" Inherits="WebApplication1.Ha_Mim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        img {
            position: absolute;
            Left: 500px;
        }
        body {
            background-color: gainsboro;
        }
        h1 {
            color: darkblue;
        }
        h2 {
            color: blue;
        }
        table,tr,td {
            border: 1px solid black;
        }
       
    </style>
<head runat="server">
    <title></title>
</head>
<body>
     <img src="pilu.jpg" alt="Ha-Mim Hyder" style="width:200px;height:228px">
    <h1>
        Ha-Mim Hyder 
    </h1>
    <h2>
        Personal Information
       
    </h2>
    
    <p>
        Email: hamim.hyder@gmail.com<br/>
        Contact No: 0171333823<br/>
        Fathers Name : Md. Hyder Ali<br/>
        Mothers Name : Meena Hyder<br/>
        Pesent Address: 39/A Rankin St. Wari Dhaka<br/>
        Permanent Address : 121/3 Nawabpur Road Dhaka<br/> 
    </p>
   <h2>
       Professional Information
   </h2>
    <p>
        Company: Aim In Life Dot Com Limited.<br/>
        Designation: Sales & Marketing Executive.<br/>
        Experience: 4 Month
    </p>
    <h2>
        Educational Information
    </h2>
    <p>
       <table >
           <tr>
               <td>
                   Degree
               </td>
               <td>
                   Institution
               </td>
               <td>
                   Year
               </td>
           </tr>
           <tr>
               <td>
                   B.Sc.(EEE)
               </td>
               <td>
                   Chittagong University Of Engineering & Technology
               </td>
               <td>
                   2014
               </td>
           </tr>
           <tr>
               <td>
                   H.S.C.
               </td>
               <td>
                   Viquarun Nessa Noon College
               </td>
               <td>
                   2008
               </td>
           </tr>
           <tr>
               <td>
                   S.S.C
               </td>
               <td>
                   St.Francis Xaviers Girls High School
               </td>
               <td>
                   2006
               </td>
           </tr>
       </table> 
    </p>
    <h2>
        Training
    </h2>
    <ul>
       <li>ASP.NET Training from BCC</li> 
        <li>PLC & Inverter Training from Industrial Automation</li>
        <li>IEEE Traing from IEEE high authority</li>
        <li>Electronics Training from TICI</li>

    </ul>
    <h2>
        Publication
    </h2>
    <p>
        A Paper on Software Defined Radio for PC to PC Data Communication.
    </p>
    <h2>
        Interests
    </h2>
    <ul>
        <li>
            Sewing
        </li>
        <li>
            Cooking
        </li>
        <li>
            Traveling
        </li>
        <li>
            Watching Television
        </li>
    </ul>
</body>
</html>
