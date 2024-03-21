var { ThingDoer } = require('../src/ThingDoer');

// To run tests, run `npm install` and then `npm test` on command line
describe('BlankTest', () => {
  it('does something', () => {
    // Arrange
    const thing = 5;

    // Act
    result = thing + 1;

    // Assert
    expect(result).toBe(10);
  });
});
