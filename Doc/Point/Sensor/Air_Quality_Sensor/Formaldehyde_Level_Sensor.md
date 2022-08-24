[Point](../../Point.md) > [Sensor](../Sensor.md) > [Air_Quality_Sensor](Air_Quality_Sensor.md) > [Formaldehyde_Level_Sensor](#)
# Formaldehyde_Level_Sensor

**Display name:** Formaldehyde Level Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Formaldehyde_Level_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
