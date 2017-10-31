NSString* UniClipboard_CreateNSString(const char* string)
{
  return [NSString stringWithUTF8String: string ? string : ""];
}

char* UniClipboard_MakeStringCopy(const char* string)
{
  if (string == NULL) return NULL;
  char* res = (char*)malloc(strlen(string) + 1);
  strcpy(res, string);
  return res;
}

extern "C"
{
  void _SetClipboard(const char* text)
  {
    NSString *nsstringText = UniClipboard_CreateNSString(text);
    UIPasteboard *pasteboard = [UIPasteboard generalPasteboard];
    pasteboard.string = nsstringText;
  }

  char *_GetClipboard()
  {
    UIPasteboard *pasteboard = [UIPasteboard generalPasteboard];
    NSString *string = pasteboard.string;
    return UniClipboard_MakeStringCopy([string UTF8String]);
  }
}

