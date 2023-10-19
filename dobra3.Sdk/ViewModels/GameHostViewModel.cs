﻿using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using dobra3.Sdk.AppModels;
using dobra3.Sdk.DataModels;
using dobra3.Shared.Utils;

namespace dobra3.Sdk.ViewModels
{
    public sealed partial class GameHostViewModel : BasePageViewModel, IAsyncInitialize
    {
        private readonly QuestionSetDataModel _questions;

        [ObservableProperty] private ObservableCollection<QuestionViewModel> _Questions;
        [ObservableProperty] private QuestionViewModel _CurrentQuestion;

        public GameHostViewModel()
        {
            
        }

        public Task InitAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        [RelayCommand]
        public async Task A_AnswerAsync()
        {

        }

        [RelayCommand]
        public async Task B_AnswerAsync()
        {

        }

        [RelayCommand]
        public async Task C_AnswerAsync()
        {

        }

        [RelayCommand]
        public async Task D_AnswerAsync()
        {

        }
    }
}
