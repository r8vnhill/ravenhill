window.highlightCode = (id, language) => {
    const element = document.getElementById(id);
    if (element) {
        if (language) {
            element.classList.add(language);
        }
        hljs.highlightBlock(element);
    }
};
