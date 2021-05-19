"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var properties_service_1 = require("./properties.service");
describe('PropertiesService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(properties_service_1.PropertiesService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=properties.service.spec.js.map