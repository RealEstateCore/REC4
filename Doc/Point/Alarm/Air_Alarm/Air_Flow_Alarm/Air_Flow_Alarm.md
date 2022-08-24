[Point](../../../Point.md) > [Alarm](../../Alarm.md) > [Air_Alarm](../Air_Alarm.md) > [Air_Flow_Alarm](#)
# Air_Flow_Alarm

**Display name:** Air Flow Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Air_Flow_Alarm;1

---


## Child interfaces
* [Air_Flow_Loss_Alarm](Air_Flow_Loss_Alarm.md)
* [High_Air_Flow_Alarm](High_Air_Flow_Alarm.md)
* [Low_Air_Flow_Alarm](Low_Air_Flow_Alarm/Low_Air_Flow_Alarm.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
