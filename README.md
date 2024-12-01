This repo demostrates how to Integrate with Google Ai Api ("Gemini)

send a request and getting a response using api Structure

Request Api Structure:
```
curl \
  -H "Content-Type: application/json" \
  -d "{\"contents\":[{\"parts\":[{\"text\":\"Explain how AI works\"}]}]}" \
  -X POST "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key=YOUR_API_KEY"
```

Response Api Structure:
```
{
  "candidates": [
    {
      "content": {
        "parts": [
          {
            "text": "Hello there! How can I help you today?\n"
          }
        ],
        "role": "model"
      },
      "finishReason": "STOP",
      "avgLogprobs": -0.001173255711116574
    }
  ],
  "usageMetadata": {
    "promptTokenCount": 2,
    "candidatesTokenCount": 11,
    "totalTokenCount": 13
  },
  "modelVersion": "gemini-1.5-flash"
}

```


To Start

1-get your api Key From : https://aistudio.google.com/apikey?_gl=1*1m2awqm*_ga*MTAwMDczNTc5OS4xNzMyNjM1MDQ1*_ga_P1DBVKWT6V*MTczMzAxMzEzNS4zLjEuMTczMzAxMzE0OC40Ny4wLjIwNzMyMjczOA..

2-replace the key With the local key in the Model Class
```
public static string apiUrl = "Your_Api_Key_Here";
```

now you can start...
