﻿using TaikoWebUI.Pages.Dialogs;

namespace TaikoWebUI.Pages;

public partial class Cards
{
    private DashboardResponse? response;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        response = await Client.GetFromJsonAsync<DashboardResponse>("api/Dashboard");
    }

    private async Task DeleteCard(User user)
    {
        var parameters = new DialogParameters
        {
            ["user"] = user
        };

        var dialog = DialogService.Show<CardDeleteConfirmDialog>("Delete Card", parameters);
        var result = await dialog.Result;

        if (result.Cancelled)
        {
            return;
        }

        response = await Client.GetFromJsonAsync<DashboardResponse>("api/Dashboard");
    }

}