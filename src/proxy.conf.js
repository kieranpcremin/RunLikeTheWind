const PROXY_CONFIG = [
  {
    context: [
      "/location",
      "/workoutplanner"
    ],
    target: "https://localhost:7051",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
