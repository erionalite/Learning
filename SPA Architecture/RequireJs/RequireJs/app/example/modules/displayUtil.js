define(["counter","logger"], function(counterModule,logger) {
    function printCount() {
        var count = counterModule.getCount();
        if (count === 1) {
            count = count + " time";
        } else {
            count = count + " times";
        }
       logger.log("Count incremented: " + count);
    }

    function displayNewCount() {
        counterModule.incrementCount();
        this.printCount();
    }
    return {
        printCount: printCount,
        displayNewCount : displayNewCount
    }
});