function UserInfoViewModel(app, name, dataModel) {
    var self = this;

    // Données
    self.name = ko.observable(name);

    // Opérations
    self.logOff = function () {
        dataModel.logout().done(function () {
            app.navigateToLoggedOff();
        }).fail(function () {
            app.errors.push("Échec de la déconnexion.");
        });
    };

    self.manage = function () {
        app.navigateToManage();
    };
}
