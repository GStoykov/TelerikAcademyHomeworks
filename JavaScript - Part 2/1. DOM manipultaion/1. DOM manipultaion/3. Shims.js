// credits: html4eto

if (!document.querySelector || !document.querySelectorAll) {
    document.querySelector = function (selector) {
        switch (selector.charAt(0)) {
            case '#': return document.getElementById(selector.substring(1, selector.lenght))[0]; break;
            case '.': return document.getElementsByClassName(selector.substring(1, selector.lenght))[0]; break;
            default: return document.getElementsByTagName(selector)[0]; break;
        }
    }

    document.querySelectorAll = function (selector) {
        switch (selector.charAt(0)) {
            case '#': return document.getElementById(selector.substring(1, selector.lenght)); break;
            case '.': return document.getElementsByClassName(selector.substring(1, selector.lenght)); break;
            default: return document.getElementsByTagName(selector); break;
        }
    }
}

