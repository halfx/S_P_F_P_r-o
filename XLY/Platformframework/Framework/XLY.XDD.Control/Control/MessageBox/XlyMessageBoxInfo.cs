﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XLY.XDD.Control
{
    /// <summary>
    /// 提示信息
    /// </summary>
    [TemplatePart(Name = "PART_Enter", Type = typeof(Button))]
    public class XlyMessageBoxInfo : System.Windows.Controls.Control
    {
        static XlyMessageBoxInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(XlyMessageBoxInfo), new FrameworkPropertyMetadata(typeof(XlyMessageBoxInfo)));
        }

        #region Message -- 消息

        /// <summary>
        /// 消息
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(XlyMessageBoxInfo), new UIPropertyMetadata(null));

        #endregion

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.PART_Enter = this.Template.FindName("PART_Enter", this) as Button;
            this.PART_Enter.Click -= new RoutedEventHandler(PART_Enter_Click);
            this.PART_Enter.Click += new RoutedEventHandler(PART_Enter_Click);

            this.PART_Enter.Focus();
        }

        private void PART_Enter_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            if (window != null)
            {
                window.Close();
            }
        }

        #region PART

        private Button PART_Enter;

        #endregion
    }


    /// <summary>
    /// 提示信息
    /// </summary>
    [TemplatePart(Name = "PART_Enter", Type = typeof(Button))]
    public class XlyMirrorMessageBoxInfo : System.Windows.Controls.Control
    {
        static XlyMirrorMessageBoxInfo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(XlyMirrorMessageBoxInfo), new FrameworkPropertyMetadata(typeof(XlyMirrorMessageBoxInfo)));
        }

        #region Message -- 消息

        /// <summary>
        /// 消息
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(XlyMirrorMessageBoxInfo), new UIPropertyMetadata(null));

        #endregion

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.PART_Enter = this.Template.FindName("PART_Enter", this) as Button;
            this.PART_Enter.Click -= new RoutedEventHandler(PART_Enter_Click);
            this.PART_Enter.Click += new RoutedEventHandler(PART_Enter_Click);

            this.PART_Enter.Focus();
        }

        private void PART_Enter_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            if (window != null)
            {
                window.Close();
            }
        }

        #region PART

        private Button PART_Enter;

        #endregion
    }
}
