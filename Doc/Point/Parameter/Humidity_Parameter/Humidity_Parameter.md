[Point](../../Point.md) > [Parameter](../Parameter.md) > [Humidity_Parameter](#)
# Humidity_Parameter

**Display name:** Humidity Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Parameter;1

---


## Child interfaces
* [High_Humidity_Alarm_Parameter](High_Humidity_Alarm_Parameter.md)
* [Humidity_Tolerance_Parameter](../Tolerance_Parameter/Humidity_Tolerance_Parameter.md)
* [Low_Humidity_Alarm_Parameter](Low_Humidity_Alarm_Parameter.md)

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
