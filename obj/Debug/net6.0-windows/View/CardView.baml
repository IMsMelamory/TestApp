   M S B A M L   `   `   `  ����B  >TestApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TestApp.ViewModelTestApp.ViewModel  5   	       TestApp.View.CardView   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5	viewmodelclr-namespace:TestApp.ViewModel     5   	     � Title$  CardView��5	   	   $	��450��6   $	��800��6'   .��5
      � .+�5   
   ��  �� Orientation$ Vertical=�6   $��5q�5   !   .+�5      �� $��Название��6   �� 5       �� 	MaxLength$ 20��6   ��5   "   �� *CurrentCard.Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors$
 true�� �� ValidatesOnExceptions$
 True�� �� NotifyOnValidationError$
 True���� 5      $ ��Производитель��6   �� 5      $ 20��6   ��5   "   �� *CurrentCard.Produser+$ PropertyChanged=�$
 true��$
 True��$
 True���� 5      $��Цена��6   �� 5      $ 20��6   ��5   "   �� *CurrentCard.Cost+$ PropertyChanged=��� 5      $��Остаток��6   �� 5      $ 20��6   ��5   "   �� *CurrentCard.Count+$ PropertyChanged=�$
 true��$
 True��$
 True���� 5      $��Фото��6   �� 5      $ 20��6   ��5   "   �� *CurrentCard.Foto+$ PropertyChanged=�$
 true��$
 True��$
 True��.��6�   5      �� 5      $��70��6   $	��100��6!   ��6-   ��  �� Path$ AddNewCardCommand�5      5      5       