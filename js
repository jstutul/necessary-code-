### 1 how to check if page is refresh or reload
Answer : let pagedata = window.performance.getEntriesByType("navigation")[0].type;
