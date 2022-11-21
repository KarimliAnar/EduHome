let skipCount = 6;
let courseCount= $("#courseCount").val()
$(document).on("click", "#loadMore", function () {
    $.ajax({
        url: "/Courses/LoadMore/",
        type: "GET",
        data: {
            "skip": skipCount
        },
        success: function (response) {
            $("#myCourse").append(response)
            skipCount += 6;
            if (courseCount <= skipCount) {
                $("#loadMore").remove()
            }

        }
    });

});