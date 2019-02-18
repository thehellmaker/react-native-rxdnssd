
#import "Rxdnssd.h"

@implementation Rxdnssd

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

@end
  