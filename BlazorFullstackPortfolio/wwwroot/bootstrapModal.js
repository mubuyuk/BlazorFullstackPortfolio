window.bootstrapModal = {
    show: (id) => {
        var modal = new bootstrap.Modal(document.querySelector(id));
        modal.show();
    },
    hide: (id) => {
        var modalElement = document.querySelector(id);
        var modal = bootstrap.Modal.getInstance(modalElement);
        if (modal) {
            modal.hide();
        }
    }
};

