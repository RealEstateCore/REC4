[Point](../../../../Point.md) > [Alarm](../../../Alarm.md) > [Air_Alarm](../../Air_Alarm.md) > [Air_Flow_Alarm](../Air_Flow_Alarm.md) > [Low_Air_Flow_Alarm](#)
# Low_Air_Flow_Alarm

**Display name:** Low Air Flow Alarm<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Low_Air_Flow_Alarm;1

---


## Child interfaces
* [Low_Discharge_Air_Flow_Alarm](Low_Discharge_Air_Flow_Alarm.md)
* [Low_Supply_Air_Flow_Alarm](Low_Supply_Air_Flow_Alarm.md)

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
