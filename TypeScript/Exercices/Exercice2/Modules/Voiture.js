"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
// import class Vehicule
var Vehicule_js_1 = require("./Vehicule.js");
// START Class Voiture
var Voiture = /** @class */ (function (_super) {
    __extends(Voiture, _super);
    function Voiture(marque, modele, kilometrage, annee, clim) {
        if (clim === void 0) { clim = "non-climatisée"; }
        var _this = _super.call(this, marque, modele, kilometrage, annee) || this;
        _this.clim = clim;
        return _this;
    }
    // Override de la méthode display()
    Voiture.prototype.display = function () {
        return "Voiture : ".concat(_super.prototype.display.call(this), " - ").concat(this.clim);
    };
    return Voiture;
}(Vehicule_js_1["default"]));
exports["default"] = Voiture;
// END Class Voiture
