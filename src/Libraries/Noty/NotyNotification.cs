﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NToastNotify.Libraries.Toastr
{
    public class NotyNotification : ToastNotification, INotyNotification
    {
        public NotyNotification(IMessageContainerFactory<NotyMessage> messageContainerFactory, NToastNotifyOption nToastNotifyOptions) : base(messageContainerFactory, nToastNotifyOptions)
        {
        }

        public void AddToastMessage(string title, string message)
        {
            var toastMessage = new NotyMessage(message, title);
            base.AddMessage(toastMessage);
        }

        public void AddToastMessage(string title, string message, NotyOptions toasILibraryOptions)
        {
            var toastMessage = new NotyMessage(message, title, toasILibraryOptions);
            base.AddMessage(toastMessage);
        }
    }
}