   M S B A M L   `   `   `  ????T  PAssignment2_Group4_SE1610, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Assignment2_Group4_SE1610.ViewAssignment2_Group4_SE1610.View  5   	   3    -Assignment2_Group4_SE1610.View.CheckoutWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Assignment2_Group4_SE1610.View     5   	   -   5          ? Title$  CheckoutWindow??5   	   $	??450??6    $	??800??6-   
????ح?.??5	      ? .+?5
   
   ]? $	??Top=?6   .+?5      ?? .+?5      ?? -   5        $??lbTitle??5      $
??Bold"?6'   $??20(?69   $??Invoice??6G   $??Center=?6Y   $??30q?6v   ? 5       ? ColumnDefinitions 5      ?? 5      $??* ?6+   ?? 5      $??* ?6+    ? RowDefinitions 5      ?? 5      $??* ?6(   .+?5      ??  ?? Orientation$ Vertical=?6!   $??10, 0, 10, 0q?68   $??0??6N   .+?5      ?? -   5        $??lbFirstName??5       $??First Name:??63   ?? 5      -   5        $??txtFirstName??5   "   $
??Left=?67   $	??385??6S   ?? 5      -   5        $??
lbLastName??5       $??
Last Name:??62   ?? 5      -   5        $??txtLastName??5   "   $
??Left=?66   $	??385??6R   ?? 5      -   5        $??	lbAddress??5       $??Address:??61   ?? 5      -   5        $??
txtAddress??5   "   $
??Left=?65   $	??385??6Q   ?? 5      -	   5        $??lbCity??5       $??City:??6.   ?? 5      -
   5        $??txtCity??5   "   $
??Left=?62   $	??385??6N   ?? 5      -   5        $??lbState??5       $??State:??6/   ?? 5      -   5        $??txtState??5   "   $
??Left=?63   $	??385??6O   ?? 5       -   5        $??	lbCountry??5        $??Country:??61   ?? 5!      -   5        $??
txtCountry??5!   "   $
??Left=?65   $	??385??6Q   5"      ?? 5#      $ Vertical=?6!   $??10, 0, 10, 0q?68   $??1??6N   .+?5$      ?? -   5        $??lbPhone??5$       $??Phone:??6/   ?? 5%      -   5        $??txtPhone??5%   "   $
??Left=?63   $	??385??6O   ?? 5&      -   5        $??lbEmail??5&       $??Email:??6/   ?? 5'      -   5        $??txtEmail??5'   "   $
??Left=?63   $	??385??6O   ?? 5(      $??Center=?6%   .+?5)      ?? -   5        $??lbTotal??5)   7   $
??Bold"?6%   $??Total:??6F   ?? 5*      -   5        $??txtTotal??5*   &   $	??100??67   ?? 5+      -   5        $??lbCash??5+   7   $
??Bold"?6%   $??Cash:??6E   ?? 5,      -   5        $??txtCash??5,   &   $	??100??66   6B   ?? 5-      -   5        $??lbRemain??5-   7   $
??Bold"?6%   $??Remain:??6G   ?? 5.      -   5        $??	txtRemain??5.   &   $	??100??68   5/      50      51      ?? 52      $ 
Horizontal=?6   $??Center=?66   .+?53      ?? -   5         ??Name$ btnSave??53      $
??Save??6.   $
??Left=?6=   $??0,20,0,0q?6X   $	??Top=?6j   $??31??6?   $??91??6?   6?   ?? 54      -   5        $ 	btnCancel??54      $??Cancel??60   $
??Left=?6A   $??
150,20,0,0q?6\   $	??Top=?6p   $??31??6?   $??91??6?   6?   55      56      57      58      5;      