# ZipExpander
Checks if the stream is zipped, and if so, decompresses, if not, returns the original.

## What is it good for
When uploading website data, there is often an upload limit. If I request the data this way, the data can be zip, gzip or uncompressed.

## Usage

Expander ex = Expander.GetExpander(stream);
Stream expandedStream = ex.Expand(stream);

If the stream was not compressed, we get it back.
If it was compressed with Zip or Gzip, we get back the decompressed data.
For a zip stream, if you find more than one file, you will get an error message.

