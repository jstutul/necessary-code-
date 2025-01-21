
    (function () {
        let devtoolsOpen = false;
        function detectDevTools() {
            const threshold = 160;
            const isMobile = /iPhone|iPad|iPod|Android/i.test(navigator.userAgent);
            if (!isMobile) {
                if (window.outerWidth - window.innerWidth > threshold || window.outerHeight - window.innerHeight > threshold) {
                    devtoolsOpen = true;
                    alert("Developer tools are open. Please close them to continue.");
                    window.location.href = '/Home/ErrorPage';
                }
            } 
        }
        detectDevTools();
        setInterval(() => {
            devtoolsOpen = false;
            detectDevTools();
        }, 1000);

        document.addEventListener('contextmenu', function (e) {
            e.preventDefault();
            alert("Right-click is disabled on this page.");
        });
        document.addEventListener('keydown', function (e) {
            const blockedKeys = [
                "F12", // F12 for developer tools
                "I",   // Ctrl+Shift+I for Inspect
                "J",   // Ctrl+Shift+J for Console
                "C",   // Ctrl+Shift+C for Elements
                "U"    // Ctrl+U for View Source
            ];
            if (
                e.key === "F12" ||
                (e.ctrlKey && e.shiftKey && blockedKeys.includes(e.key.toUpperCase())) ||
                (e.ctrlKey && e.key.toUpperCase() === 'U')
            ) {
                e.preventDefault();
                alert("Developer tools are disabled!");
            }
        });
    })();
