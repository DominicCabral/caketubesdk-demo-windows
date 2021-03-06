﻿namespace CakeTubeSdk.Demo.ViewModel
{
    using Prism.Mvvm;

    /// <summary>
    /// Request authentication code window view model.
    /// </summary>
    public class RequestAuthCodeViewModel : BindableBase
    {
        /// <summary>
        /// Authentication code.
        /// </summary>
        private string authCode;

        /// <summary>
        /// Authentication code.
        /// </summary>
        public string AuthCode
        {
            get => this.authCode;
            set
            {
                this.SetProperty(ref this.authCode, value); 
                this.RaisePropertyChanged(nameof(this.IsOkButtonEnabled));
            }
        }

        /// <summary>
        /// OK button enabled flag.
        /// </summary>
        public bool IsOkButtonEnabled
        {
            get => !string.IsNullOrWhiteSpace(this.AuthCode);
        }
    }
}