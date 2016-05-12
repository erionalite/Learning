requirejs.config({
    baseUrl: "app/example",
    paths: {
        counter: "modules/counter",
        util: "modules/displayUtil",
        logger:"modules/logger"
    }
});

require(["util"], function(utilModule) {
    utilModule.displayNewCount();
    utilModule.displayNewCount();
});