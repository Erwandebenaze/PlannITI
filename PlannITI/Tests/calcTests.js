// This the testing template, you need jasmine.js and http://chutzpah.codeplex.com/
// Reference the tested script AND jasmine, then in VS launch Tests --> Execute --> All tests

/// <reference path="../Scripts/jasmine.js" />
function Calculator() {
}

Calculator.prototype.add = function (num1, num2) {
    return num1 + num2;
}

Calculator.prototype.subtract = function (num1, num2) {
    return num1 - num2;
}

Calculator.prototype.divide = function (num1, num2) {
    return num1 / num2;
}

Calculator.prototype.multiply = function (num1, num2) {
    return num1 * num2;
}

describe("Calculator", function () {
    var calculator;
    beforeEach(function () {
        calculator = new Calculator();
    });

    it("add should add two numbers", function () {
        var result = calculator.add(5, 5);
        expect(result).toBe(9);
    });

    it("subtract should subtract two numbers", function () {
        var result = calculator.subtract(5, 5);
        expect(result).toBe(0);
    });

    it("multiply should multiply two numbers", function () {
        var result = calculator.multiply(5, 5);
        expect(result).toBe(25);
    });

    it("divide should divide two numbers", function () {
        var result = calculator.divide(5, 5);
        expect(result).toBe(1);
    });
});