using System;

namespace example_library {

  public class MessageGenerator {
    private int messageIndex = 0;

    public String generate() {
      return "Message" + (messageIndex++);
    }
  }

}
