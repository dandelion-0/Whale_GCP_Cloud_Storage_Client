# Whale_GCP_Cloud_Storage_Client_Browser

Whale GCP Cloud Storage Client Browser is a C# application with a WinForms user interface that allows users to interact with Google Cloud Storage. It provides various functionalities such as creating buckets, deleting buckets, downloading a whole bucket, downloading objects, uploading objects, deleting objects, and retrieving a list of objects in a bucket.

## Prerequisites

Before using this application, you need to create a JSON credentials file and enable the required API in your Google Cloud Platform (GCP) project. Here are the steps to follow:

1. **Create JSON Credentials**
   - Go to the [Google Cloud Console](https://console.cloud.google.com/).
   - Select your project (or create a new one).
   - In the left sidebar, click on "APIs & Services" and then "Credentials".
   - Click on "Create credentials" and select "Service account".
   - Enter a name for the service account and choose the appropriate role (e.g., "Storage Object Admin" if you want to perform all the functionalities provided by this application).
   - Leave the "Key Type" as JSON and click on "Create".
   - The JSON credentials file will be downloaded to your computer.

2. **Enable Cloud Storage API**
   - In the Google Cloud Console, go to "APIs & Services" and then "Library".
   - Search for "Cloud Storage API" and click on it.
   - Click on the "Enable" button.

## Installation

To use this application, you need to follow these steps:

1. Clone the repository:
   

   git clone https://github.com/dandelion-0/Whale_GCP_Cloud_Storage_Client_Browser.git
   


2. Open the solution file (`Whale_GCP_Cloud_Storage_Client_Browser.sln`) in Visual Studio.

3. Build the solution to restore the NuGet packages and compile the application.

4. Copy the JSON credentials file (created in the prerequisites step) to the `bin/Debug/..` or `bin/Release` folder, depending on your build configuration.

5. Add json credentials path in credentials varialble from Form.cs --> Right Click - ViewCode --> Ctrl+F - "credentials"

6. Run the application by clicking on the "Start" button in Visual Studio or by executing the generated executable file.

## Usage

Once the application is running, you can use the WinForms user interface to interact with Google Cloud Storage. The available functionalities are:

- **Create Bucket**: Enter a unique name for the bucket and click on the "Create Bucket - Process" button to create a new bucket in your GCP project.
- **Delete Bucket**: Select a bucket from the dropdown list and click on the "Delete Bucket - Process" button to delete the selected bucket.
- **Download Whole Bucket**: Select a bucket from the dropdown list and click on the "Download Whole Bucket - Process" button to download all the objects in the selected bucket.
- **Download Object**: Select a bucket and an object from their respective dropdown lists and click on the "Download Object - Process" button to download the selected object.
- **Upload Object**: Select a bucket and a file from their respective dropdown lists, enter a desired name for the uploaded object, and click on the "Upload Object - Process" button to upload the selected file to the selected bucket.
- **Delete Object**: Select a bucket and an object from their respective dropdown lists and click on the "Delete Object - Process" button to delete the selected object from the selected bucket.
- **Get List of Objects**: Select a bucket from the dropdown list and click on the "Get List of Objects - Process" button to retrieve a list of objects in the selected bucket.

Note: Make sure you have the necessary permissions to perform these actions in your GCP project.

## Contributing

Contributions are welcome! If you have any ideas or suggestions, please create a new issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgements

Whale GCP CLoud Storage Browser was developed using the following libraries and frameworks:

- [Google Cloud_Storage SDK for .NET]([https://aws.amazon.com/sdk-for-net/](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Storage.V1/latest))
- [WinForms](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-7.0&viewFallbackFrom=net-desktop-5.0)

Special thanks to the contributors who have made this project possible.

## Contact

For any questions or inquiries, please contact the project maintainer at [dandelion00@tutanota.com]

Feel free to visit our project page on GitHub: [Whale GCP_Cloud_Storage_Browser](https://github.com/dandelion-0/Whale_GCP_Cloud_Storage_Client_Browser)
