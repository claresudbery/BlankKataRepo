// Tests are in TemplateTest.spec.js
class ThingDoer {
    constructor() {
    }

    doSomething(value) {
        return value + 1;
    }
}

module.exports = { ThingDoer: ThingDoer };
