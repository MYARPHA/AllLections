   M S B A M L   `   `   `  ����F  BLection0516, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Lection0516Lection0516  5   	       Lection0516.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Lection0516     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   �� -   5        $��soundplayer��5
      $
��Play��6$    � Triggers 5      :� 5       :� RoutedEvent$ Button.Click��6   [�5      �� 5      .��5      �� .��5   "   p�  p� Source$ video\game intro.mp4?�60    �� 
TargetName$ myMediaElement��5   +    g� RepeatBehavior$ Forever��5   +   5      5      5      5      �� 5   
   -   5         ��Name$ testSoundPlayer��5      $��test soundPlayer��5      5      �� 5   
   -   5        $ testSystemSound��5      $��testsystemSound��5      5      �� 5!   
   -   5        $ testMediaPlayer��5!      $��test mp3��5"      5#      r� 5%   
    r� Source$ 
forest.wav?�6   r� 5&   
   -   5         r�Name$ myMediaElement��5&      	 r� LoadedBehavior$	 Manual=�6/   
 J� Clip
 5'      @� 5(       @� Center$ 100, 200&�6"    @� RadiusX$	 200Q�64    @� RadiusY$	 100Q�6B    � LayoutTransform 5*      �� 5+       �� Angle$ 60Q�6"   5-      �� 5.   
   -   5         ��Name$ image��5.      $	��200��6   $	��300��6+   �� 5/   
   -   5        $ pauseMediaPlayer��5/      $��pause��6J   51      52      