﻿using Microsoft.Maui.Controls;
using System;

namespace MauiChat.Maui.Controls
{
    public partial class MessageView
    {
        public static BindableProperty UsernameProperty = BindableProperty.Create(nameof(Username), typeof(string), typeof(MessageView), null);
        public static BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(string), typeof(MessageView), null);
        public static BindableProperty IsMeProperty = BindableProperty.Create(nameof(IsMe), typeof(bool), typeof(MessageView), null);
        public static BindableProperty IsNotMeProperty = BindableProperty.Create(nameof(IsNotMe), typeof(bool), typeof(MessageView), null);
        public static BindableProperty AvatarIconProperty = BindableProperty.Create(nameof(AvatarIcon), typeof(string), typeof(MessageView), null);

        public string Username
        {
            get => (string)GetValue(UsernameProperty);
            set
            {
                SetValue(UsernameProperty, value);
                Console.WriteLine("Username changed");
            }

        }

        public string Message
        {
            get => (string)GetValue(MessageProperty);
            set => SetValue(MessageProperty, value);
        }

        //public int AvatarId
        //{
        //    get => (int)GetValue(AvatarIdProperty);
        //    set => SetValue(AvatarIdProperty, value);
        //}

        public bool IsMe
        {
            get => (bool)GetValue(IsMeProperty);
            set
            {
                SetValue(IsMeProperty, value);
                if(value == true)
                {
                    MyMessageGrid.IsVisible = true;
                    TheirMessageGrid.IsVisible = false;
                }
                else
                {
                    MyMessageGrid.IsVisible = false;
                    TheirMessageGrid.IsVisible = true;
                }
            }
        }

        public bool IsNotMe
        {
            get => (bool)GetValue(IsNotMeProperty);
            set => SetValue(IsNotMeProperty, value);
        }


        public string AvatarIcon
        {
            get => (string)GetValue(AvatarIconProperty);
            set => SetValue(AvatarIconProperty, value);
        }

        public MessageView()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
