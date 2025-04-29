document.querySelector("#load-friends-button").addEventListener("click", async function () {
  //example che k bank application ma statement load krvu hoi, on specific button nai k pehla page load thai tyare j krvanu hoi. to aa technique use thai che.
  var response = await fetch("friends-list", { method: "GET" });
  var responseBody = await response.text();
  document.querySelector("#list").innerHTML = responseBody;
});