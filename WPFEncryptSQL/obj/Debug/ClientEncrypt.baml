   M S B A M L   `   `   `  ����H  DWPFEncryptSQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFEncryptSQLWPFEncryptSQL  5   	   !    WPFEncryptSQL.ClientEncrypt   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFEncryptSQL     5   	     � Title$  ClientEncrypt��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ 
label_Copy��5
      $��Imię��6$   $
��Left=�63   $��26��6N   $��	10,73,0,0q�6Z   $	��Top=�6m   $��88��6�   �� 5   
   -   5        $ label_Copy1��5      $��Nazwisko��6%   $
��Left=�68   $��26��6S   $��
10,104,0,0q�6_   $	��Top=�6s   $��88��6�   �� 5   
   -   5        $ label_Copy2��5      $��Login��6%   $
��Left=�65   $��26��6P   $��
10,135,0,0q�6\   $	��Top=�6p   $��88��6�   �� 5   
   -   5        $ label_Copy3��5      $��Haslo��6%   $
��Left=�65   $��26��6P   $��
10,166,0,0q�6\   $	��Top=�6p   $��88��6�   �� 5   
   -   5         ��Name$ txt_firstName��5      $
��Left=�6)   $��26��6D   $��
103,73,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6y   $��98��6�   �� 5   
   -   5        $ txt_Name��5      $
��Left=�6$   $��26��6?   $��103,104,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $��98��6�   �� 5   
   -   5        $ 	txt_Login��5      $
��Left=�6%   $��26��6@   $��103,135,0,0q�6L   $
 Wrap=�6a   $	��Top=�6v   $��98��6�   �� 5   
   -   5        $ txt_Pass��5      $
��Left=�6$   $��26��6?   $��103,166,0,0q�6K   $
 Wrap=�6`   $	��Top=�6u   $��98��6�   �� 5   
   -	   5         ��Name$ listView��5      $
��Left=�6%   $	��119��6@   $��
388,73,0,0q�6M   $	��Top=�6a   $	��350��6y    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$
 auto��6\    �� DisplayMemberBinding 61   �� *	id_client+6\   �� 5      $
��imie��6%   $
 auto��6^    63   �� *	firstname+6^   �� 5      $��Nazwisko��6%   $
 auto��6`    67   �� *	surname+6`   �� 5      $��Login��6%   $
 auto��6g    64   �� *Login_Name_Unique+6g   �� 5      $��Haslo��6%   $
 auto��6c    64   �� *Password_text+6c   5      5      5      5      